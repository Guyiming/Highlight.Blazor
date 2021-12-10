window.loadCss = (url) => {
    if (!url || url.length === 0) {
        throw new Error('argument "url" is required !');
    }
    var head = document.getElementsByTagName('head')[0];
    var link = document.createElement('link');
    link.href = url;
    link.rel = 'stylesheet';
    link.type = 'text/css';
    head.appendChild(link);
};