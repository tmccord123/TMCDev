var dictionary = {
    de: {
        coupon_for: 'Gutschein anzeigen',
        coupons_for: 'Gutscheine anzeigen',
        weFoundCoupons: 'Es stehen Gutscheine zur Verfügung!',
        powered_by: 'Ad by',
        save_now: 'Jetzt sparen',
        coupons_available_for_1: 'Für',
        coupons_available_for_2: 'gibt es Gutscheine & Angebote'
    },
    en: {
        coupon_for: 'coupon available',
        coupons_for: 'coupons available',
        weFoundCoupons: 'We have found coupons for this webpage!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
    },
    es: {
        coupon_for: 'cupón disponible',
        coupons_for: 'cupones disponibles',
        weFoundCoupons: '¡Hemos encontrado cupones para este sitio!',
        powered_by: 'Ad by',
        save_now: 'Ahorra ya',
        coupons_available_for_1: '¡Hay cupones y ofertas disponibles en',
        coupons_available_for_2: ''
    },
    pt: {
        coupon_for: 'coupon disponível',
        coupons_for: 'coupons disponíveis',
        weFoundCoupons: 'Encontramos cupons para este site!',
        powered_by: 'Ad by',
        save_now: 'Economize agora',
        coupons_available_for_1: 'Há cupons e ofertas para',
        coupons_available_for_2: ''
    },
    fr: {
        coupon_for: 'bon disponible',
        coupons_for: 'bons disponibles',
        weFoundCoupons: 'Nous avons trouvé des bons de réduction pour ce site!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
    },
    it: {
        coupon_for: 'coupon disponibile',
        coupons_for: 'coupon disponibili',
        weFoundCoupons: 'Abbiamo trovato dei coupon per questo sito!',
        powered_by: 'Ad by',
        save_now: 'Risparmia adesso',
        coupons_available_for_1: 'Poi ci sono buoni sconto e offerte su',
        coupons_available_for_2: ''
    },
    pl: {
        coupon_for: 'kupon dostępny',
        coupons_for: 'kupony dostępne',
        weFoundCoupons: 'Znaleźliśmy kupony dla tej strony!',
        powered_by: 'Ad by',
        save_now: 'Oszczędzaj teraz',
        coupons_available_for_1: 'Dla sklepu',
        coupons_available_for_2: 'są dostępne kupony & oferty'
    },
    ru: {
        coupon_for: 'Доступный купон',
        coupons_for: 'Доступных купонов',
        weFoundCoupons: 'Мы нашли купоны для этой веб-страницы!',
        powered_by: 'Ad by',
        save_now: 'Сэкономить сейчас',
        coupons_available_for_1: 'Для',
        coupons_available_for_2: 'есть купоны и спецпредложения'
    },
    nl: {
        coupon_for: 'coupon beschikbaar',
        coupons_for: 'coupons beschikbaar',
        weFoundCoupons: 'We hebben coupons voor deze website gevonden!',
        powered_by: 'Ad by',
        save_now: 'Bespaar nu',
        coupons_available_for_1: 'Er zijn coupons & aanbiedingen voor',
        coupons_available_for_2: ''
    },
    no: {
        coupon_for: 'kupong tilgjengelig',
        coupons_for: 'kuponger tilgjengelig',
        weFoundCoupons: 'Vi har funnet kuponger for denne nettsiden!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
    },
    sv: {
        coupon_for: 'kupong tillgänglig',
        coupons_for: 'kuponger tillgängliga',
        weFoundCoupons: 'Vi har hittat kuponger för denna webbsida!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
    },
    tr: {
        coupon_for: 'mevcut Kupon',
        coupons_for: 'mevcut Kuponlar',
        weFoundCoupons: 'Bu internet sayfası için kuponlar bulduk!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
    },
    fi: {
        coupon_for: 'kuponki saatavilla',
        coupons_for: 'kuponkeja saatavilla',
        weFoundCoupons: 'We have found coupons for this webpage!',
        powered_by: 'Ad by',
        save_now: 'Save now',
        coupons_available_for_1: 'Coupons & offers available for',
        coupons_available_for_2: ''
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

