var dictionary = {
    de: {
        coupon_code: 'GUTSCHEINCODE',
        click_to_copy: 'Zum kopieren klicken!',
        instructions: 'ANLEITUNG',
        instructions_text: 'Klicke auf den Code um diesen zu kopieren. Trage den Gutscheincode im Warenkorb im Gutscheincode-Feld ein und der Rabatt wird automatisch abgezogen.',
        successfully_copied: 'Erfolgreich kopiert!',
        powered_by: 'powered by'
    },
    en: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    },
    es: {
        coupon_code: 'Código de descuento',
        click_to_copy: '¡Haz clic para copiar!',
        instructions: 'Instrucciones',
        instructions_text: 'Haz clic en el código de descuento para copiarlo. Insértalo en la casilla correspondiente en el carrito de compra. El descuento se reflejará automáticamente en el carrito.',
        successfully_copied: 'Con éxito copiado!',
        powered_by: 'powered by'
    },
    pt: {
        coupon_code: 'CÓDIGO DO CUPOM',
        click_to_copy: 'Clique para copiar!',
        instructions: 'INSTRUÇÕES',
        instructions_text: 'Clique no código para copiá-lo. Cole-o no campo reservado para o código do cupom em seu carrinho de compras e o desconto será aplicado automaticamente.',
        successfully_copied: 'Copiado com sucesso!',
        powered_by: 'powered by'
    },
    fr: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    },
    it: {
        coupon_code: 'Codici promozionali',
        click_to_copy: 'Clicca per copiare!',
        instructions: 'Istruzioni',
        instructions_text: 'Fare clic sul codice per copiarlo. Inserisci il codici nel carrello nel campo codice e verrà applicato lo sconto.',
        successfully_copied: 'Copiato con successo!',
        powered_by: 'powered by'
    },
    pl: {
        coupon_code: 'Kod rabatowy',
        click_to_copy: 'Kliknij żeby kopiować!',
        instructions: 'Instrukcja',
        instructions_text: 'Kod będzie kopiowany, jeżeli na niego klikniesz. Wklej ten kod w pole kodu rabatowego koszyka sklepu internetowego i otrzymasz zniżkę automatycznie.',
        successfully_copied: 'Pomyślnie skopiowane!',
        powered_by: 'powered by'
    },
    ru: {
        coupon_code: 'Коды купона',
        click_to_copy: 'Кликните, чтобы скопировать',
        instructions: 'Инструкции',
        instructions_text: 'Кликните на код, чтобы его скопировать. Введите код купона в соответствующее поле для ввода купона, и скидка будет автоматически высчитана.',
        successfully_copied: 'Успешно копируются!',
        powered_by: 'powered by'
    },
    nl: {
        coupon_code: 'Couponcode',
        click_to_copy: 'Klik om te kopiëren!',
        instructions: 'Gebruiksaanwijzing',
        instructions_text: 'Klik op de code om deze te kopiëren. Plak de couponcode in het betreffende veld van de winkelwagen, en de korting wordt automatisch verrekend.',
        successfully_copied: 'Gekopieerd!',
        powered_by: 'powered by'
    },
    no: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    },
    sv: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    },
    tr: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    },
    fi: {
        coupon_code: 'Coupon codes',
        click_to_copy: 'Click to copy!',
        instructions: 'INSTRUCTIONS',
        instructions_text: 'To copy the code, click on it. Enter the coupon code in the designated field in your shopping cart and the discount will be automatically deducted.',
        successfully_copied: 'Successfully copied!',
        powered_by: 'powered by'
    }
};

var storage = {
    get: function(key, defaultValue) {
        if (localStorage[key]) {
            try {
                return JSON.parse(localStorage[key]);
            } catch (ex) {
            }
        }
        if (defaultValue === undefined) {
            return null;
        }
        return defaultValue;
    },
    set: function(key, newValue) {
        localStorage[key] = JSON.stringify(newValue);
    },
    remove: function(key) {
        if (localStorage[key]) {
            delete localStorage[key];
        }
    }
};

var language = (function() {
    var detectedLanguage = storage.get('detectedLanguageV2', null);

    if (detectedLanguage) {
        return detectedLanguage;
    }

    detectedLanguage = 'en';

    // list from http://msdn.microsoft.com/en-us/library/windows/apps/jj657969.aspx
    var supportedLanguages = {
        de: ['de', 'de-de', 'de-ch', 'de-at', 'de-lu', 'de-li'],
        es: ['es', 'es-es', 'es-ar', 'es-bo', 'es-cl', 'es-co', 'es-cr', 'es-do', 'es-ec', 'es-gt', 'es-hn', 'es-mx', 'es-ni', 'es-pa', 'es-pe', 'es-pr', 'es-py', 'es-sv', 'es-uy', 'es-ve'],
        fr: ['fr', 'fr-fr', 'fr-be', 'fr-ca', 'fr-ch', 'fr-lu'],
        it: ['it', 'it-it', 'it-ch'],
        pt: ['pt', 'pt-br', 'pt-pt'],
        ru: ['ru', 'ru-ru'],
        pl: ['pl', 'pl-pl'],
        nl: ['nl', 'nl-nl', 'nl-be'],
        no: ['nb', 'nb-no', 'nn', 'nn-no', 'no', 'no-no'],
        sv: ['sv', 'sv-se', 'sv-fi'],
        tr: ['tr', 'tr-tr']
    };

    var navigatorLanguage = ((navigator.language) ? navigator.language : navigator.userLanguage).toLowerCase();
    for (var languageCode in supportedLanguages) {
        if (supportedLanguages[languageCode].indexOf(navigatorLanguage) > -1) {
            detectedLanguage = languageCode;
            break;
        }
    }

    storage.set('detectedLanguageV2', detectedLanguage);
    return detectedLanguage;
})();

var userLanguage = dictionary[language];

