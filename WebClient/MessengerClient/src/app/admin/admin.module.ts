import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GroupComponent } from './group/group.component';
import { ClientsComponent } from './clients/clients.component';
import { CreateClientComponent } from './clients/create-client/create-client.component';


@NgModule({
  imports: [
    CommonModule,
  ],
  declarations: [
    GroupComponent,
    ClientsComponent,
    CreateClientComponent,
  ]
})
export class AdminModule { }
