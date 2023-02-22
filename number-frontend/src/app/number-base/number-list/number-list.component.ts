import { Component, OnInit } from '@angular/core';
import { NumberService } from 'src/app/services/number.service';
import { INumber } from '../models/inumber';

@Component({
  selector: 'app-number-list',
  templateUrl: './number-list.component.html',
  styleUrls: ['./number-list.component.css']
})
export class NumberListComponent implements OnInit {
  public numbers: INumber[] = [];

  constructor(private numberService: NumberService) { }

  ngOnInit(): void {
    this.getHeroes();
  }

  getHeroes(): void {
    this.numberService.getNumbers()
      .subscribe(
        (numbers: INumber[]) => this.numbers = numbers
      );
  }

}
