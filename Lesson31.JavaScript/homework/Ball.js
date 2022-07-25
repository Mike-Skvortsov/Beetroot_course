const balloon = document.getElementById("balloon");
size = 1;
balloon.style.fontSize = `${size}em`;
const changeSize = (item) => {
  const key = item.key;
  if (key === "ArrowDown") {
    item.preventDefault();
    size -= 0.1 * size;
    balloon.style.fontSize = `${size}em`;
  } else if (key === "ArrowUp") {
    item.preventDefault();
    size += 0.1 * size;
    balloon.style.fontSize = `${size}em`;
  }
  if (size > 10) {
    var element = document.getElementById("balloon");
    element.innerHTML = "💥";
    document.removeEventListener("keydown", changeSize);
  }
};

document.addEventListener("keydown", changeSize);
