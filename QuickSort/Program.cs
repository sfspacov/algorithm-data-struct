// [8, 2, 5, 9, 1, 6, 10]
var arrayCagado = new int[] { 8, 2, 5, 9, 1, 6, 10 };
var arrayBonito = Quick(arrayCagado, 0, arrayCagado.Length - 1);
foreach (var item in arrayBonito)
{
    Console.WriteLine(item);
}
static int[] QuickSort(int[] arrayCagado, int low, int high)
{
    var i = low;
    var j = high;
    var pivot = arrayCagado[i];

    while (i <= j)
    {
        while (pivot > arrayCagado[i])
            i++;

        while (pivot < arrayCagado[j])
            j--;

        if (i <= j)
        {
            var temp = arrayCagado[j];
            arrayCagado[j] = arrayCagado[i];
            arrayCagado[i] = temp;
            i++;
            j--;
        }
    }
    if (low < j)
        QuickSort(arrayCagado, low, j);
    if (high < i)
        QuickSort(arrayCagado, i, high);
    return arrayCagado;
}

static int[] Quick(int[] array, int low, int high)
{
    var i = low;
    var j = high;
    var pivot = array[i];

    while (i <= j)
    {
        while (pivot > array[i])
            i++;

        while (pivot < array[j])
            j--;

        if (i <= j)
        {
            var temp = array[j];
            array[j] = array[i];
            array[i] = temp;
            i++;
            j--;
        }

        if (low < j)
            Quick(array, low, j);

        if (high > i)
            Quick(array, i, high);
    }

    return array;
}