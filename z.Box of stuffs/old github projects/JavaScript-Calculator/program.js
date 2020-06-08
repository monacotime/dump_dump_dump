var x;
var y;
var z;
//------------------------------------------------------------------------------

function inputNum(i){
	if (i === "num1"){
		x = parseInt(prompt("input num 1"));
		document.getElementById("n1").value = x;
	};
	if (i === "num2"){
		y = parseInt(prompt("input num 2"));
		document.getElementById("n2").value = y;
	};
};


function calc(i){
	if (i=== "+"){
		z = x+y;
		document.getElementById("result").value = z;
	};
	if (i=== "-"){
		z = x-y;
		document.getElementById("result").value = z;
	};
	if (i=== "/"){
		z = parseInt(x/y);
		document.getElementById("result").value = z;
	};
	if (i=== "*"){
		z = x*y;
		document.getElementById("result").value = z;
	};
};

