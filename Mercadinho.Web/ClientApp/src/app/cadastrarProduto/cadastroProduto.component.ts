import {Component, OnInit } from '@angular/core';
import { Produto } from '../modelo/produto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CadastroService } from '../Service/cadastro.service';
import { ProdutoService } from '../Service/produto.service';

@Component({
    selector:'app-cadastroProduto',
    templateUrl: './cadastroProduto.component.html',
    styleUrls: ['./cadastroProduto.component.css']
})

export class CadastroProdutoComponent implements OnInit{

    public produto : Produto;

    constructor(private ProdutoService : ProdutoService){ 

    }
ngOnInit(){
this.produto = new Produto();
}




public cadastroSubmit(){
    this.ProdutoService.post(this.produto)
    //alert(this.produto.nomeProduto + this.produto.precoUnitario + this.produto.quantidade);
    .subscribe(
        (retorno: Produto)=> {
            console.log(retorno)
        },
        (erro: any)=> {
            console.log(erro);
        }
    );
}


}