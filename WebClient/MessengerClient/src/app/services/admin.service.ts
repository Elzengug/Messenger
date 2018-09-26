import { Injectable } from '@angular/core';
import {  Response, Http, Headers } from '@angular/http';

import { Client } from '../models/client';
import { environment } from '../../environments/environment';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class AdminService {
adress: string = "";
  constructor(private http: Http, private rout: Router) { 
    this.adress = environment.host;
  }
  createClient(client: Client){
    const body = 'clientName=' +client.clientName +'&clientEmail=' + client.clientEmail;
    const createHeaders= new Headers({'Content-Type': 'application/x-www-form-urlencoded'});
    this.http.post(this.adress + 'api/Admin/AddClient',
    JSON.stringify(body),
      { headers: createHeaders }
    ) 
    .subscribe(err => console.log(err));
  }
}
