import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {Routes, RouterModule} from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AuthComponent } from './auth/auth.component';
import { AdminComponent } from './admin/admin.component';
import { HomeComponent } from './home/home.component';
import { GroupComponent } from './admin/group/group.component';
import { ClientsComponent } from './admin/clients/clients.component';
import { LoginComponent} from './auth/login/login.component';

const adminRoutes: Routes =[
  { path: 'group', component: GroupComponent },
  { path: 'clients', component: ClientsComponent },
];
const authRoutes: Routes =[
  { path: 'login', component: LoginComponent },
];
const appRoutes: Routes =[
  { path: 'home', component: HomeComponent },
  { path: 'admin', component: AdminComponent, children: adminRoutes },
  { path: 'auth', component: AuthComponent, children: authRoutes },
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes),
    BrowserModule,
    FormsModule,
    HttpModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  declarations: [
    AppComponent,
    AuthComponent,
    LoginComponent,
    AdminComponent,
    HomeComponent,
    GroupComponent,
    ClientsComponent,
    
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
