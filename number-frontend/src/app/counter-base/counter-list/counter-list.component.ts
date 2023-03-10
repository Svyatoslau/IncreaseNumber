import { Component, OnInit } from '@angular/core';
import { CounterService } from 'src/app/services/counter.service';
import { ICounter } from '../models/counter';

@Component({
  selector: 'app-counter-list',
  templateUrl: './counter-list.component.html',
  styleUrls: ['./counter-list.component.css']
})
export class CounterListComponent implements OnInit {
  public counters: ICounter[] = [];

  constructor(private counterService: CounterService) { }

  ngOnInit(): void {
    this.getCounters();
  }

  getCounters(): void {
    this.counterService.getCounters()
      .subscribe(
        (counters: ICounter[]) => this.counters = counters
      );
  }

}
