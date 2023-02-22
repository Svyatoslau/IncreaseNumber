import { Component, Input, OnInit } from '@angular/core';
import { NumberService } from 'src/app/services/number.service';
import { INumber } from '../models/inumber';
import { Increment } from '../models/increment';

@Component({
  selector: 'app-number-detail',
  templateUrl: './number-detail.component.html',
  styleUrls: ['./number-detail.component.css']
})
export class NumberDetailComponent implements OnInit {
  @Input()
  public number!: INumber;
  @Input()
  public incr!: number;

  constructor(private numberService: NumberService) { }

  ngOnInit() {

  }

  increaseNumber(incr: number, id: number): void{
    let increment: Increment = {
      value: incr
    }

    this.numberService.increaseNumber(id, increment)
      .subscribe(
        (num: INumber) => this.number = num
      );
  }

}
