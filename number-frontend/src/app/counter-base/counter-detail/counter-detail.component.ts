import { Component, Input, OnInit } from '@angular/core';
import { CounterService } from 'src/app/services/counter.service';
import { ICounter } from '../models/counter';
import { Increment } from '../models/increment';

@Component({
  selector: 'app-counter-detail',
  templateUrl: './counter-detail.component.html',
  styleUrls: ['./counter-detail.component.css']
})
export class CounterDetailComponent implements OnInit {
  @Input()
  public counter!: ICounter;
  @Input()
  public incr!: number;

  constructor(private counterService: CounterService) { }

  ngOnInit() {

  }

  increaseCounter(incr: number, id: number): void{
    let increment: Increment = { value: incr }

    this.counterService.increaseCounter(id, increment)
      .subscribe(
        (counter: ICounter) => this.counter = counter
      );
  }

}
