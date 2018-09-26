import { Component, OnInit } from '@angular/core';
import { Client } from '../../../models/client';
import { AdminService } from '../../../services/admin.service';

@Component({
  selector: 'app-create-client',
  templateUrl: './create-client.component.html',
  styleUrls: ['./create-client.component.css']
})
export class CreateClientComponent  {
 
  client: Client = new Client();
  constructor(private adminService : AdminService) { }

  submit(client: Client){
    this.adminService.createClient(client);
  }
}
