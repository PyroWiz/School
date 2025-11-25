document.addEventListener('DOMContentLoaded', () =>
{
    const button1 = document.getElementById('btn1');
    const button2 = document.getElementById('btn2');
    const text = document.getElementById('text');
    button1.addEventListener('click', () =>
    {
        text.innerHTML = 'Visit <a href ="https://www.google.co.il/webhp?source=search_app" target="_blank">Google</a>';
    });

    button2.addEventListener('click', () => { 
        text.innerHTML = 'text';
    });
});