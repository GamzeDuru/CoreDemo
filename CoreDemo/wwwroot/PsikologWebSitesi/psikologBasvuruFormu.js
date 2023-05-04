var input = document.querySelector("#telefon");
    intlTelInput(input, {
        utilsScript: "/js/utils.js", // Telefon kodlarını getiren dosya
        // initialCountry: "tr", // Varsayılan olarak Türkiye'yi getir
        // nationalMode: false // otomatik olarak input'a ekle
    }); 