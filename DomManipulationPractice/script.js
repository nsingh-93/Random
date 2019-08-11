const container = document.querySelector('#container');

const content = document.createElement('div');
content.classList.add('content');
content.textContent = 'This is the glorious text-content!';

container.appendChild(content);

const para = document.createElement('p');
para.style.cssText = 'color: red;';
para.textContent = 'Hey I\'m red!';

container.appendChild(para);

const h3 = document.createElement('h3');
h3.style.cssText = 'color: blue;';
h3.textContent = 'I\'m a blue h3!';

container.appendChild(h3);

const borderedDiv = document.createElement('div');

const containedH1 = document.createElement('h1');
containedH1.textContent = 'I\'m in a div!';

const containedP = document.createElement('p');
containedP.textContent = 'ME TOO!';

borderedDiv.appendChild(containedH1);
borderedDiv.appendChild(containedP);

borderedDiv.style = 'border: solid 1px black; background-color: pink;'

container.appendChild(borderedDiv);