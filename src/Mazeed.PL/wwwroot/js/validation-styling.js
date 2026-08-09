// Overriding jQuery unobtrusive validation defaults to support Bootstrap 5 styles
$.validator.setDefaults({
    errorClass: "",
    validClass: "",

    highlight: function (element, errorClass, validClass) {
        // Apply Bootstrap red boundary highlight on validation failure
        $(element).addClass("is-invalid").removeClass("is-valid");
        
        // Append Bootstrap feedback styling to error spans
        $(element.form)
            .find("[data-valmsg-for='" + element.id + "']")
            .addClass("invalid-feedback");
    },

    unhighlight: function (element, errorClass, validClass) {
        // Apply Bootstrap green boundary success highlight
        $(element).addClass("is-valid").removeClass("is-invalid");
        
        // Remove error text class
        $(element.form)
            .find("[data-valmsg-for='" + element.id + "']")
            .removeClass("invalid-feedback");
    },
});