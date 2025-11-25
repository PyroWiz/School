document.addEventListener("DOMContentLoaded", () => {
    const container = document.getElementById("table-container");
    const table = document.createElement("table");
    table.style.borderCollapse = "collapse";
    table.style.width = "100%";

    let fir = Number(prompt("enter first number"))
    let sec = Number(prompt("enter second number"))

    for (let i = 1; i <= fir; i++) {
        const row = document.createElement("tr");
        for (let j = 1; j <= sec; j++) {
            const cell = document.createElement("td");
            const value = i * j;
            cell.textContent = value;
            cell.style.border = "1px solid black";
            cell.style.padding = "5px";
            cell.style.textAlign = "center";
            let check = 0;
            for (let x = 1; x <= value; x++) {
                if (value % x === 0) check++;
            }
            if (check >2)
            {
                cell.style.backgroundColor= "green";
                cell.style.fontWeight = "normal";
            }
            else{
                cell.style.backgroundColor= "yellow";
                cell.style.fontWeight = "bold";
            }
            row.appendChild(cell);
        }
        table.appendChild(row);
    }

    container.appendChild(table);
});
