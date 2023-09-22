const uri = 'api/todoitems';

const zapros = document.getElementById('otpr');
const poriadok = ['В1', 'В2', 'В9', 'В10-1', 'В11', 'В12', 'В13', 'В14', 'В15', 'В16-1', 'В17', 'ДЖ1', 'ДЖ2', 'M34', 'M35', 'П11', 'П22']

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => {
            console.log(data);
            _displayItems(shaper(data));
        })
        .catch((error) => {
            console.error('Unable to get items.', error)
            alert('Ошибка ПОЛУЧЕНИЯ данных! Обратитесь к Владиславу Романовичу')
            zapros.style.display = 'block'
        });
}

function shaper(s) {
    var z = []
    for (let a = 0; a < poriadok.length; a++) {
        for (let d = 0; d < s.length; d++) {
            if (poriadok[a] == s[d]) {
                z.push(s[d], s[d + 1], s[d + 2], s[d + 3])
            }
        }
    }
    return z
}


function addItem() {
    const addNameTextbox = document.getElementById('add-name');
    zapros.style.display = 'none'
    const item = {
        isComplete: false,
        name: addNameTextbox.value.trim()
    };
    afterClick();
    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item),
    })
        .then(response => response.json())
        .then(() => {
            addNameTextbox.value = '';
            console.log("add38")
            getItems();
        })
        .catch((error) => {
            console.error('Unable to add item.', error)
            alert('Ошибка ЗАПРОСА данных! Обратитесь к Владиславу Романовичу')
            zapros.style.display = 'block'
        })
}


function _displayItems(data) {
    const tBody = document.getElementById('todos');
    tBody.innerHTML = '';

    for (let item = 0; item < data.length;) {

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let textNode1 = document.createTextNode(data[item]);
        td1.appendChild(textNode1);

        let td2 = tr.insertCell(1);
        let textNode2 = document.createTextNode(data[item + 1]);
        let ulkaLoveCock = parseFloat(data[item + 1].replace(',', '.'))
        let dvuhBratiev = parseFloat(data[item + 2][0].concat(data[item + 2][1]))
        let penicVpope = parseFloat(data[item + 2][3].concat(data[item + 2][4]))
        console.log(penicVpope);
        if (ulkaLoveCock > penicVpope || ulkaLoveCock < dvuhBratiev) {
            td2.style.cssText = 'color: red; border: 2px solid red'
        }
        td2.appendChild(textNode2);

        let td3 = tr.insertCell(2);
        let textNode3 = document.createTextNode(data[item + 2]);
        td3.appendChild(textNode3);

        let td4 = tr.insertCell(3);
        let textNode4 = document.createTextNode(data[item + 3]);
        td4.appendChild(textNode4);
        item = item + 4;
    }
    zapros.style.display = 'block'
}

function auth() {
    fetch('api/auth')
        .then(response => response.json())
        .then(aut => {
            console.log(aut);
        })
        .catch(error => console.error('Unable to authentification', error));
}


const poluchka = document.getElementById('poluchka');
poluchka.addEventListener('click', () => {
        afterClick(OPC);
    }
)

function afterClick(opc) {
    zapros.style.display = 'none'
}





