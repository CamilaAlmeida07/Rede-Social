$(document).ready(function(){

	var flag = false;

	$("#menu").hover(function(){
		$("#nav li>a>p").delay(800).css('visibility', 'visible');
		flag = true;
	});
	$("#menu").mouseout(function(){
		$('#nav li>a>p').delay(800).css('visibility', 'hidden');
	});
	
	$('#nav li>a').click(function(){
		$('.selected').removeClass('selected');
		$(this).addClass('selected');
	});

	$('.post>.comentario').addClass('comentarioImpar');
	$('.comentarioImpar>.comentario').addClass('comentarioPar');
	$('.comentarioPar>.comentario').addClass('comentarioImpar');
	
});