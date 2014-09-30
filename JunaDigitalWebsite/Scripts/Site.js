$('#contactForm').submit(function (event) {
    event.preventDefault();

    var url = $('#messageUrl').val();
    var formData = $('#contactForm').serialize();
    $.post(url, formData, function (result) {
        if (result.MessageSent) {
            $('#contactForm').hide();
            $('#mailSentAlert').show();
        }
    });
});