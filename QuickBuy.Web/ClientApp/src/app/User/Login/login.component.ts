import { Component } from "@angular/core";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  entrar() {
    console.log("Entrar no sistema");
  }

  on_keypress() {
    console.log("FieldEmail");
  }
}
