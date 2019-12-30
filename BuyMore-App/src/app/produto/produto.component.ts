import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html',
  styleUrls: ['./produto.component.css']
})
export class ProdutoComponent implements OnInit {

  public nome: string;
  public liberadoParaVenda: string;

  public obterNome(): string {
    return this.nome;
  }

  constructor() { }

  ngOnInit() {
  }

}
