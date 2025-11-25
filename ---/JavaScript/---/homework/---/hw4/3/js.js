import { showmsg } from "./func.js";
document.addEventListener("DOMContentLoaded", () =>
{
    const buttons = document.querySelectorAll("button");
    buttons.forEach((button) =>
    {
        button.addEventListener("click", () =>
        {
            const id = button.id;
            const msg = popups[id];
            if (msg)
            {
                showmsg(msg);
            }
        })
    });

    var popups = {
        1: 'clicked on person 1',
        2: 'clicked on person 2',
        3: 'clicked on person 3',
    }
});