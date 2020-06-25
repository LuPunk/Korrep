# 2. óra: HTML5 és CSS

## HTML5 Tag-ek

- Gyakorlatilag div-ek
- Miért jó? Miért vezették be?
- header/nav/section/article/aside/footer
- Példa!!

---

## CSS

- Mi a CSS?

- Mire jó?

- CSS használatának módjai (PRECEDENCIA):

  - Inline CSS: A HTML tag-ben ``` <h1 stlye="color:black;">``` 

  - Internal CSS: style tag-ek között lévő 

    ``` html
    <style>
        h1 {
            color:black;
        }
    </style>
    ```

    

  - Külső CSS .css fájl linkelése:

    ```html
    <link rel="stylesheet" type="text/css" href="style.css">
    ```

    

- Felépítése

```
a -> szelektor 
{
	background-color -> tuladonság
	: -> elválasztó
    yellow -> érték
    ; -> befejező
}
```

- Kiválasztás

  ```
  a, h1 - elem szerinti kiválasztás (lehet több is)
  .valami - osztály alapú kiválasztás
  #valami azonosító alapú kiválasztás
  ```

- Színek megadása

  - név (black)
  - HTML név
  - Hexadecimális
  - RGB

- Betűk

  - ```
    font-family: 1., 2., 3.
    ```

  - Beépített/Külső

  - ```
    font-size: 16px (méret)
    ```

  - ```
    font-weight: bold; (szöveg erőssége)
    ```

  - ```
    Öszzesítve: font: normal 16px Arial, Helvetica, sans-serif
    ```

  - ```
    line-height: 3px (sormagasság)
    ```

  - ```
    font-style: italic
    ```

  - ```
    text-decoration: underline
    ```

  - ```
    text-transform: uppercase
    ```

  - 

- Népszerű tulajdonságok:

  - background-color (háttérszín)

  - background-image: url()

  - color (betűszín)

  - Box modell: 

  - ```
    https://miro.medium.com/max/733/1*pBPPK_ZIS2KTRCvGVs2Q1g.png
    ```

    - egyben írva top-right-bottom-left
    - felső alsó: felsőalsó baljobb

  - Keret/border

    - vastagság szín típus
    - radius: lekerekítés

  - Elhelyezés

    - text-align: center

  - Lista

    - list-style:
    - list-stlye-image

  - float

    - left/right
    - box-sizing: border-box veszi a bordert paddingot és úgy alakítja a szélességhez
    - clear: both;

  - postion:

    - absolute/relative/fixed
    - 

- Linkek

  - státusz
    - normal
    - active (mikor épp rákattintasz)
    - hover
    - visited