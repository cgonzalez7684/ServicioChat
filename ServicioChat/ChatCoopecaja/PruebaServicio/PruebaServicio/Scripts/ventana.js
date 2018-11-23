//var head = document.getElementsByTagName('head')[0];
//var body = document.getElementsByTagName('body')[0];

//var link = document.createElement('link');
//link.rel = 'stylesheet';
//link.type = 'text/css';
//link.href = 'http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css';
//link.media = 'all';
//head.appendChild(link);



var DivC = document.createElement("DIV");
DivC.className = "collapse";
DivC.id = "collapseExample";
DivC.style.position = "absolute";
DivC.style.width = "500px";
DivC.style.height = "250px";
DivC.style.bottom = "0%";
DivC.style.right = "1%";

var DivD = document.createElement("DIV");
DivD.className = "well";

var DivE = document.createElement("DIV");
DivE.className = "modal-content";
DivE.style.width = "450px";
DivE.style.height = "250px";


var oFrm = document.createElement("IFRAME");
oFrm.setAttribute("frameborder", "0");
oFrm.src = "servidor.aspx";
oFrm.height = "250px";
oFrm.width = "450px";

DivE.appendChild(oFrm);






DivD.appendChild(DivE);
DivC.appendChild(DivD);

document.body.appendChild(DivC);




var oDiv = document.createElement("button");
oDiv.className = "btn btn-primary";
oDiv.type = "button";
oDiv.setAttribute('data-toggle', 'collapse');
oDiv.setAttribute('data-target', '#collapseExample');
oDiv.setAttribute('aria-expanded', 'false');
oDiv.setAttribute('aria-controls', 'collapseExample');
oDiv.style.position = "absolute";
oDiv.innerText = "Iniciar Chat!";
oDiv.style.bottom = "0%";
oDiv.style.right = "0%";



var oBotonTi = document.createElement("SPAN");
oBotonTi.className = "glyphicon glyphicon-send";

oDiv.appendChild(oBotonTi);

document.body.appendChild(oDiv);





