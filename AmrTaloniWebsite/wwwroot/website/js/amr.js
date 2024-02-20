/*global $,  document, window*/

$(document).ready(function () {
   
	'use strict';

	// Change Header Height
	$('.carousel-item').height($(window).height());


	// navbar links scroll smoothly to div
    $('.dropdown .dropdown-item').click(function () {

        // e.preventDefault();
		
        $('html,body').animate({
			
            scrollTop: $('#' + $(this).data('value')).offset().top + 1
			
        }, 1000);
    });
	
	$('.selected-features option').click(function () {
		$('html, body').animate({
			scrollTop: $('#'+ $(this).data('value')).offset().top
		}, 2000);
	});

 // Caching The Scroll Top Element
	var scrollButton = $("#scroll-top");
    
    $(window).scroll(function () {
        
        if ($(this).scrollTop() >= 600) {
            
            scrollButton.show();
            
        } else {
			
            scrollButton.hide();
        }
	});
	
	// Click On Button To Scroll Top
    scrollButton.click(function () {
        $("html,body").animate({ scrollTop : 0 }, 1000);
    });
	
	
	// Add Class Scrolled in navbar
	$(window).scroll(function () {
		
		var navbar = $('.header');
		
		if ($(window).scrollTop() >= navbar.height()) {
			
			navbar.addClass('scrolled');
			
		} else {
			
			navbar.removeClass('scrolled');
		}
	});
	
	
	// start counter
    $(".counter").counterUp({
        delay: 10,
        time: 1000
    });
	
	
	// Toggle Product Description
	$('.products .product i, .items .item i ').on('click', function () {
		
		$(this).toggleClass('fa-plus fa-minus').next('.description').slideToggle();
		
	});
	
 // Show Hidden Items From Work
    $('.view').click(function () {
       
        $(' .hidden').fadeIn(1000);
        
    });
	
	//Light Slider  
	$("#lightSlider").lightSlider({
		item: 2,
		autoWidth: false,
		slideMove: 2, // slidemove will be 1 if loop is true
		slideMargin: 18,
		rtl: true,
		loop: true,
		slideEndAnimation: true
	});
	
	// Nice Scroll
    $("html").niceScroll({
		
		cursorcolor: "#312782",
		cursorwidth: "10px",
		cursorheight: "100px",
		cursorborder: "2px solid #222",
		cursorborderradius: "15px",
		scrollspeed: "50",
		horizrailenabled: false
	});
    
    /* ToolTip */
    $(function () {
		
		$('[data-toggle="tooltip"]').tooltip();
	});
	
	/* Our Clients = Home Page */
	$(document).ready(function() {
		$("#clients-slider").lightSlider({
			loop:true,
			item:5,
			keyPress:true
		});
	});

});
