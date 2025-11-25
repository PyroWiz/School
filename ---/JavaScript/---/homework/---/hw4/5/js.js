document.addEventListener('DOMContentLoaded', () =>
{
    const table = document.getElementById('myTable');
    let clickTimer = null;

    table.addEventListener('click', (e) =>
    {
        if (clickTimer) return;
        clickTimer = setTimeout(() =>
        {
            table.style.width = '50%';
            clickTimer = null;
        }, 250);
    });

    table.addEventListener('dblclick', (e) =>
    {
        clearTimeout(clickTimer);
        clickTimer = null;
        table.style.width = '100%';
    });
});