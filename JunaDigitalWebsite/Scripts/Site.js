$('#contactForm').submit(function (event) {
    event.preventDefault();
    document.body.style.cursor = "wait";
    var url = $('#messageUrl').val();
    var formData = $('#contactForm').serialize();
    $.post(url, formData, function (result) {
        if (result.MessageSent) {
            $('#contactForm').hide();
            $('#mailSentAlert').show();
        }
    }).always(function () {
        document.body.style.cursor = "default";
    });
});