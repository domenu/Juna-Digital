$(document).on('click', '#sendMessageButton', function (e) {
    e.preventDefault();
    if ($('#contactForm')[0].checkValidity()) {
        var formData = $('#contactForm').serialize();
        $.post('/home/sendmessage', formData, function (result) {
            console.log(result);
        });
    }
    return false;
});