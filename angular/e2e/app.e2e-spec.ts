import { evitoriav2TemplatePage } from './app.po';

describe('evitoriav2 App', function() {
  let page: evitoriav2TemplatePage;

  beforeEach(() => {
    page = new evitoriav2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
