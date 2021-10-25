import { Component, OnInit, TemplateRef } from '@angular/core';
import { Jogo } from '../models/Jogos';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
@Component({
  selector: 'app-jogos',
  templateUrl: './jogos.component.html',
  styleUrls: ['./jogos.component.css'],
})
export class JogosComponent implements OnInit {

  public modalRef!: BsModalRef;
  public jogoForm!: FormGroup;
  public titulo = "Jogos para escolher";
  public JogoSelecionado!: string;
  public textSimple!: string;

  public Jogos = [
    { id: 1, nome: 'Super Mario Galaxy' },
    { id: 2, nome: 'The Legend of Zelda: Ocarina of Time (N64)' },
  ]

  openModal(template: TemplateRef<any>,) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, private modalService: BsModalService
  ) {
    this.criarForm();
  }

  ngOnInit(): void {
  }

  criarForm() {
    this.jogoForm = this.fb.group({
      nome: ['', Validators.required],
    });
  }
  jogoSubmit() {
    console.log(this.jogoForm.value);

  }

  jogoSelect(Jogo: Jogo) {
    this.JogoSelecionado = Jogo.nome;
    this.jogoForm.patchValue(Jogo);
  }

  voltar() {
    this.JogoSelecionado = '';
  }



}
