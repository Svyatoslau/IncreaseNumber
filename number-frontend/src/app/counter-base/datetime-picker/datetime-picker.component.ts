import { Component, Input, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { CounterService } from 'src/app/services/counter.service';

@Component({
  selector: 'app-datetime-picker',
  templateUrl: './datetime-picker.component.html',
  styleUrls: ['./datetime-picker.component.css']
})
export class DatetimePickerComponent implements OnInit {
  public date: string = "";
  public color: ThemePalette = "accent"
  @Input()
  public id!: number;

  constructor(private counterService: CounterService) { }
  
  ngOnInit() {
  }
  
  dateUpdated(): void{
    this.counterService.updatePikedDate(this.id, this.date).subscribe();
  }
}
