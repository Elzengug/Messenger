import { Component, OnInit } from '@angular/core'
import { User } from '../../models/user';
import { AuthService } from '../../services/auth.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  user: User = new User();
  receivedUser: User;
  done: boolean = false;
  constructor(private authService: AuthService) { 
      this.user.password = '111111aA!';
  }
  submit(user: User) {
    this.authService.login(user)
  }
}
