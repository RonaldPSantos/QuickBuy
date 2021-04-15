import { Component } from "@angular/core";
import { User } from "../../model/User";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public user;

  constructor() {
    this.user = new User();
  }
  
  entrar() {
    
  }

}
