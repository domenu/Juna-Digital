$('#contactForm').submit(function (event) {
    event.preventDefault();

    var formData = $('#contactForm').serialize();
    $.post('/home/sendmessage', formData, function (result) {
        if (result.MessageSent) {
            $('#contactForm').hide();
            $('#mailSentAlert').show();
        }
    });
});