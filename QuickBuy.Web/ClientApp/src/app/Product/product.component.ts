import { Component } from "@angular/core"

@Component({
  selector: "",
  template: "<html><body>{{ getName() }}</body></html>"
})
export class ProductComponent {
  public name: string;
  public toSale: boolean;

  public getName(): string {
    return "Samsung";
  }

}
