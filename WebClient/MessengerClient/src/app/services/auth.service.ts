import { Injectable } from '@angular/core';
import {  Response, Http, Headers } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User, AuthUser } from '../models/user';
import { environment } from '../../environments/environment';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})

export class AuthService {
  adress: string = "";
  constructor(private http: Http, private rout: Router) {
    this.adress = environment.host;
  }
  login(user: User) {
    const body = 'username=' + user.userName+ '&password=' + user.password + '&grant_type=password';
  

    const authHeaders= new Headers({'Content-Type': 'application/x-www-form-urlencoded'});
    this.http.post(this.adress + 'Token',
    body,
      { headers: authHeaders }
    )
    .pipe(map(response => response.json()))
    .subscribe(
      data => this.saveJwt(data.access_token, data.userName),
      err => console.log(err),
      () => console.log()
    );
  }
      saveJwt(jwt, login) {
        if (jwt && login) {
          localStorage.setItem('userName', login);
          localStorage.setItem('id_token', jwt);
          this.rout.navigate(['/home']);
      }
    }

    public isAuthorize(): boolean {
      const jwt = localStorage.getItem('id_token');
      return jwt ? true : false;
    }
    logout() {
      localStorage.removeItem('userName');
      localStorage.removeItem('id_token');
    }
}


