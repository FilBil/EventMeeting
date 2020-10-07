import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Event Meeting Project';
  footer = 'Some footer shit';

  // functionalities mock
  functionalities = ['Mieszaknia na Wynajem',
                     'Turystyka Miejska',
                     'Turystyka Imprezowa',
                     'SOS'];
}
