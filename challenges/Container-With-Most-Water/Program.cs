MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

int MaxArea(int[] array)
{

    var l = 0;
    var r = array.Length - 1;
    var max = 0;
    while (l < r)
    {
        var area = array[l] < array[r] ?
            array[l] * (r - l) :
            array[r] * (r - l);

        if (area > max)
            max = area;

        if (array[l] < array[r])
            l++;
        else
            r--;
    }

    return max;
}