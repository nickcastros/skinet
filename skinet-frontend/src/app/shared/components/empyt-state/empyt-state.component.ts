import { Component } from '@angular/core';
import { MatButton } from '@angular/material/button';
import { MatIcon } from '@angular/material/icon';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-empyt-state',
  standalone: true,
  imports: [MatIcon, MatButton, RouterLink],
  templateUrl: './empyt-state.component.html',
  styleUrl: './empyt-state.component.scss',
})
export class EmpytStateComponent {}
