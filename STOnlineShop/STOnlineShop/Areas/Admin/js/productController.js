


var product = {
    init: function () {
        product.registerEvents();
    },
    registerEvents: function () {

        $('.btn-images').off('click').on('click', function (e) {
            e.preventDefault();
            $('#myModal').modal('show');
            $('#hidProductID').val($(this).data('id'));
        });

        $('#btn-default').off('click').on('click', function () {
            $('#myModal').modal('hide');
        });

        $('#btnChooImages').off('click').on('click', function (e) {
            e.preventDefault();
            var finder = new CKFinder();
            finder.selectActionFunction = function (url) {
                $('.imagesList').append('<div style=" float:left"> <img src="' + url + '" width="100"<a href="#"><span width="15px" class="btn-deImage">&times;</span></a></div>');
                $('.btn-deImage').off('click').on('click', function (e) {
                    e.preventDefault();
                    $(this).parent().remove();
                })

            };
            finder.popup();
        });
    }
}
product.init();




//window.onclick = function (event) {
//    if (event.target == modal) {
//        modal.style.display = "none";
//    }
//}



