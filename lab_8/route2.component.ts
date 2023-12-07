import { Component , OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-route2',
  standalone: true,
  imports: [CommonModule, MatCardModule, MatButtonModule],
  templateUrl: './route2.component.html',
  styleUrl: './route2.component.scss'
})
export class Route2Component implements OnInit {

  public word = ['start', 'merge (am luat din lista cuvantul dupa ce am apasat pe buton)'];
  public displayValue: string = '';

  ngOnInit() {
    this.displayValue = this.word[0];
  }

  buttonGet() {
    this.displayValue = this.word[1];
  }
}
