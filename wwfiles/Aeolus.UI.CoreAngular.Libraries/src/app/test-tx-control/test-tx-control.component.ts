import { Component, OnInit, AfterViewInit } from '@angular/core';

declare let TXTextControlWeb;
declare let TXTextControl;
// declare let textControl1;

@Component({
  selector: 'hene-test-tx-control',
  templateUrl: './test-tx-control.component.html',
  styleUrls: ['./test-tx-control.component.scss']
})
export class TestTxControlComponent implements OnInit {
  public textControl1: any;

  constructor() { }

  ngOnInit() {
    this.textControl1 = new TXTextControlWeb('myTextControlContainer');
  }

  loadText() {
    const data = localStorage.getItem('txData');
    if (data) {
      this.textControl1.loadDocument(TXTextControl.StreamType.HTMLFormat, data);
    }
  }

  opslaan() {
    this.textControl1.saveSelection(TXTextControl.StreamType.HTMLFormat, (tx) => {
      console.log(tx);
      localStorage.setItem('txData', tx.data);
    });
  }

}
