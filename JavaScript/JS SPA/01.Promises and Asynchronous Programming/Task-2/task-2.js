(function () {
    
    const milisecondsBeforeRedirect = 2000;

    let popup = document.getElementById('popup');

    popup.innerHTML = "You will get redirected to Telerik Academy's website in two seconds.";
    popup.style.backgroundColor = '#4CAF50';
    popup.style.color = 'white';
    popup.style.padding = '20px';
    popup.style.width = '50%';
    popup.style.textAlign = 'center';
    popup.style.margin = 'auto';
    alert("You will get redirected after pressing OK :)");

    function timeout() {
        let promise = new Promise((resolve, reject) => {
            return setTimeout(() => {
                resolve({});
            }, milisecondsBeforeRedirect);
        });

        return promise;
    }

    timeout()
        .then(success => {
            window.location = "https://telerikacademy.com/";
        });

}());