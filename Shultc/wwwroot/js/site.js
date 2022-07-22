$(document).scroll(function (e) {
    $(window).scrollTop() > 100 ? $('.nav').addClass('nav__color') : $('.nav').removeClass('nav__color');
});