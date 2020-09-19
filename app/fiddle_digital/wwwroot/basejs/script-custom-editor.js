$(document).ready(function () {
    // Initialize Editor
    //$('.textarea-editor').wysihtml5();
    $('.textarea-editor').summernote(
        {
            height: 300,                 // set editor height
            minHeight: null,             // set minimum height of editor
            maxHeight: null,             // set maximum height of editor
            focus: true,                  // set focus to editable area after initializing summernote
            callbacks: {
                onImageUpload: function (files, editor, welEditable) {
                    sendFile(files[0], editor, welEditable);
                }
            }
        });

    function sendFile(file, editor, welEditable) {
        data = new FormData();
        data.append("uploadedFile", file);
        $.ajax({
            data: data,
            type: "POST",
            url: "/admin/article/addfile",
            cache: false,
            contentType: false,
            processData: false,
            success: function (url) {
                $('.textarea-editor').summernote('insertImage', url);
            }
        });
    }
});
