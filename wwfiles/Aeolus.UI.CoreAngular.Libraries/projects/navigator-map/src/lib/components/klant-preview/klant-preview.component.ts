import { Component, OnInit, Input } from '@angular/core';
import { PreviewItem } from '../../models/previewItem';

@Component({
  selector: 'hene-klant-preview',
  templateUrl: './klant-preview.component.html',
  styleUrls: ['./klant-preview.component.scss']
})
export class KlantPreviewComponent implements OnInit {
  @Input() itemPreview: PreviewItem;
  constructor() { }

  ngOnInit() {
  }

}
