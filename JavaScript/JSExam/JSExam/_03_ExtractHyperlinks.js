function countLinks(html) {
    var index = 0;
    var re = new RegExp("ab+c");

    for (var i = 0; i < html.length; i++) {
        if (html[i].match(re)) {
            console.log(html[i].match(re))
        }
    }
}

countLinks('<!DOCTYPE html>' +
                        '<html>' +
                        '<head lang="en">' +
                            '<meta charset="UTF-8">' +
                                '<title>index</title>' +
                                '<script src="/yourScript.js" defer></script>' +
                            '</head>' +
                            '<body>' +
                                '<div id="outerDiv">' +
                                   '<div' +
                                    'class="first">' +
                                       '<div><div>hello</div></div>' +
                                    '</div>' +
                                    '<a href="#"></a>' +
                                    '<a id="href">href='+'fake'+'<img src='+ "http://abv.bg/i.gif" +
                                '</div>' +
                            '</body>' +
                        '</html>')