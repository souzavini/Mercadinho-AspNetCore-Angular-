import {Component, OnInit } from '@angular/core';
import { Produto } from '../modelo/produto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProdutoService } from '../Service/produto.service';

@Component({
    selector:'app-produto',
    templateUrl: './Produto.component.html',
    styleUrls: ['./Produto.component.css']
})

export class ProdutoComponent implements OnInit{
    public produtoForm: FormGroup;
    titulo = 'Produtos';
    public produtoSelecionado: Produto;

    public produtos: Produto[];

    constructor(private fb: FormBuilder,private produtoService: ProdutoService){
        this.criarForm();
     }

    ngOnInit(){
        this.carregarProduto();
    }

    carregarProduto(){
        this.produtoService.getAll().subscribe(
            (produtos: Produto[]) => { 
                this.produtos = produtos;
            },
            (erro: any) =>{
                console.error(erro);
             }
        )
    }

    criarForm(){
        this.produtoForm = this.fb.group({
            Quantidade:['',Validators.required],
            PrecoUnitario:['',Validators.required],
            NomeProduto:['',Validators.required]

        });
    }
    
    produtoSubmit(){
        console.log(this.produtoForm.value);
    }
    produtoSelect(produto: Produto){
        this.produtoSelecionado = produto;
        this.produtoForm.patchValue(produto);
    }
    voltar(){
        this.produtoSelecionado = null;
    }

    
}