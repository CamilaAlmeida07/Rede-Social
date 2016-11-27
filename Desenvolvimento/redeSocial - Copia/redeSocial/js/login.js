function centralizar() {

	var windowWidth = window.innerWidth;
	var windowHeight = window.innerHeight;

	var itemHeight = $('.centralizar').height();
	var itemWidth = $('.centralizar').width();

	var itemLeft = (windowWidth - itemWidth) / 2 - 10;
	var itemTop = (windowHeight - itemHeight) / 2 - 10;

	$('.centralizar').css("left", itemLeft);
	$('.centralizar').css("top", itemTop);
};


$(window).resize(function () {
	centralizar();
});

$(function () {
	centralizar();
});



function validarCamposLogin() {

	if (document.getElementById('id').value == "") 
	{
		document.getElementById('id').focus();
		// ScreenAlert('Opa!', 'É necessário preencher todos os campos', 'warning');
		alert("Preencha todos os carmpos");
		return false;
	} 
	else if (document.getElementById('senha').value == "") 
	{
		document.getElementById('senha').focus();
		alert("Preencha todos os campos");
		return false;
	}

	return true;
};