$(document).ready(function(){


	// $("nav").hover(function(){
	// 	$("#conteudo").delay(5000).css('opacity', '.2');
	
	// });
	// $("nav").mouseout(function(){
	// 	$("#conteudo").delay(1000).css('opacity', '1');
	// });
	
	$('nav li>a').click(function(){
		$('.selected').removeClass('selected');
		$(this).addClass('selected');
	});

	$('.post>.comentario').addClass('comentarioImpar');
	$('.comentarioImpar>.comentario').addClass('comentarioPar');
	$('.comentarioPar>.comentario').addClass('comentarioImpar');
	
});