$(function (){	
	//banner
    var sWidth = $(".slide").width();
    var len = $(".slide ul li").length;
    var index = 0;
    var picTimer;

    var btn = "<div class='btn'>";
    for (var i = 0; i < len; i++) {
        btn += "<span></span>";
    }
    $(".slide").append(btn);

    $(".slide .btn span").mouseover(function ()
    {
        index = $(".slide .btn span").index(this);
        showPics(index);
    }).eq(0).trigger("mouseover");
    $(".slide ul").css("width", sWidth * (len));

    $(".slide").hover(function ()
    {
        clearInterval(picTimer);
    }, function ()
    {
        picTimer = setInterval(function ()
        {
            showPics(index);
            index++;
            if (index == len) { index = 0; }
        }, 5000);
    }).trigger("mouseleave");

    function showPics(index)
    {
        var nowLeft = -index * sWidth;
        $(".slide ul").stop(true, false).animate({ "left": nowLeft }, 200);
        $(".slide .btn span").removeClass("on").eq(index).addClass("on");
    };
	$(".close-btn").click(function(){
		$(".pop").hide();
	});
  });
$(document).ready(function () {
	var ht=$(".viewport").width()*32/75;
	$(".banner,.banner-img li,.banner-img li img").height(ht);
	$(".banner").hover(function(){
		$(".banner-btn").show()
		},function(){
		$(".banner-btn").hide()
		})
	$dragBln = false;
	$(".bnn-main").touchSlider({
		flexible : true,
		speed : 200,
		btn_prev : $(".prevBtn"),
		btn_next : $(".nextBtn"),
		paging : $(".banner-circle li"),
		counter : function (e) {
			$(".banner-circle li").removeClass("selected").eq(e.current-1).addClass("selected");
		}
	});
	$(".bnn-main").bind("mousedown", function() {
		$dragBln = false;
	})
	$(".bnn-main").bind("dragstart", function() {
		$dragBln = true;
	})
	$(".bnn-main a").click(function() {
		if($dragBln) {
			return false;
		}
	})
	timer = setInterval(function() { $(".nextBtn").click();}, 10000);
	$(".banner").hover(function() {
		clearInterval(timer);
	}, function() {
		timer = setInterval(function() { $(".nextBtn").click();}, 10000);
	})
	$(".bnn-main").bind("touchstart", function() {
		clearInterval(timer);
	}).bind("touchend", function() {
		timer = setInterval(function() { $(".nextBtn").click();}, 10000);
	})
});