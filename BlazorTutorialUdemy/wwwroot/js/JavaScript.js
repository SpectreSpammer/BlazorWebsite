window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Operation Successful', { timeOut: 5000 })

    }

    if (type === "error") {
        toastr.error(message, 'Operation Failed', { timeOut: 5000 })

    }
}

window.ShowSweetAlert = (type, message) => {
    if (type === "success") {
        Swal.fire({
            title: "Sucess Notification",
            text: message,
            icon: "success"
        });

    }

    if (type === "error") {
   
        Swal.fire({
            icon: "error",
            title: "Oops...",
            text: "Something went wrong!",
            footer: '<a href="#">Why do I have this issue?</a>'
        });

    }
}