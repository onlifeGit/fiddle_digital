$(document).ready(function () {
    var id;
    var url;

    $('')

    $('#upload').click(function () {

        var fd = new FormData();
        var files = $('#file')[0].files[0];
        fd.append('file', files);

        // AJAX request
        $.ajax({
            url: 'upload.php',
            type: 'post',
            data: fd,
            contentType: false,
            processData: false,
            success: function (response) {
                if (response !== 0) {
                    // Show image preview
                    $('.success-message').html('File was uploaded successfully');
                } else {
                    $('.success-message').html('Something wrong');
                }
            }
        });
    });
});