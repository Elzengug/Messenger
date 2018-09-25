import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GroupComponent } from './group/group.component';
import { ClientsComponent } from './clients/clients.component';


@NgModule({
  imports: [
    CommonModule,
  ],
  declarations: [
    GroupComponent,
    ClientsComponent,
  ]
})
export class AdminModule { }
