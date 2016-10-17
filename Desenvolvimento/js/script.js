$(document).ready(function(){
	$('#nav li>a').click(function(){
		$('.selected').removeClass('selected');
		$(this).addClass('selected');
	});

	$('.post>.comentario').addClass('comentarioImpar');
	$('.comentarioImpar>.comentario').addClass('comentarioPar');
	$('.comentarioPar>.comentario').addClass('comentarioImpar');
	
});