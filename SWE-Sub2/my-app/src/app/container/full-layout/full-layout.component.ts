import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fulllayout',
  templateUrl: './full-layout.component.html',
  styleUrls: ['./full-layout.component.scss']
})
export class FullLayoutComponent {

  navbarCollapsed = true;

  constructor() { }
}
