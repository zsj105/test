// JScript source code
/*
����ʾ��
$.conlitionTable({
    rows: $("#tb1 tbody tr"),    //����Ҫ�еĲ���  ��Ҫ�ϲ���������
    direction: "h",                      //��ѡ  hΪˮƽ�ϲ�  v �Ǵ�ֱ�ϲ�(Ĭ��)
    //urows:[1]                
});

$.conlitionTable({
    rows: $("#tb3 tbody tr"),    //����Ҫ�еĲ���  ��Ҫ�ϲ���������
    direction: "v",                      //��ѡ  hΪˮƽ�ϲ�  v �Ǵ�ֱ�ϲ�(Ĭ��)
    ucols: [0,3]                        //��ѡ ���Ϊv�ϲ�  columns�����Ǽ���  ��д����������
});

*/
$.extend({
    conlitionTable: function (e) {
        var _ucols = e.ucols ? e.ucols : "";
        var _urows = e.urows ? e.urows : "";
        var _rows = e.rows;
        var _rlength = _rows.length;                //��������
        var _clength = _rows[0].cells.length;   //��������
        var _direction = !e.direction ? "v" : e.direction;
        conlition = function () {
            if (_direction == "h") {
                for (var i = _rlength - 1; i >= 0; i--) {
                    var colspan = 1;        //������
                    var _cv = { v: "", r: "", c: "" }; //cv��ǰ��        v=ֵ  r=�� c=��
                    var _pv = { v: "", r: "", c: "" }; //pv��һ��ֵ     v=ֵ  r=�� c=��
                    _cv.v = _rows[i].cells[_clength - 1].innerHTML; ;
                    _cv.r = i;
                    _cv.c = _clength - 1;
                    for (var j = _clength - 2; j >= 0; j--) {
                        if (_urows != "") {
                            for (var k = _urows.length - 1; k >= 0; k--) {
                                if (_urows[k] == i) {
                                    _pv.v = _rows[i].cells[j].innerHTML;
                                    _pv.r = i;
                                    _pv.c = j;
                                    if (_cv.v == _pv.v) {
                                        colspan += 1;
                                        _rows[_pv.r].cells[_pv.c].colSpan = colspan;
                                        _rows[_pv.r].deleteCell(_cv.c);
                                    }
                                    else {
                                        colspan = 1;
                                    }
                                    _cv.v = _pv.v;
                                    _cv.r = _pv.r;
                                    _cv.c = _pv.c;
                                }
                            }
                        }
                        else {
                            _pv.v = _rows[i].cells[j].innerHTML;
                            _pv.r = i;
                            _pv.c = j;
                            if (_cv.v == _pv.v) {
                                colspan += 1;
                                _rows[_pv.r].cells[_pv.c].colSpan = colspan;
                                _rows[_pv.r].deleteCell(_cv.c);
                            }
                            else {
                                colspan = 1;
                            }
                            _cv.v = _pv.v;
                            _cv.r = _pv.r;
                            _cv.c = _pv.c;
                        }
                    }
                }
            }
            //����ϲ���ʼ
            if (_direction == "v") {
                for (var i = _clength - 1; i >= 0; i--) {
                    var rowspan = 1;        //������
                    var _cv = { v: "", r: "", c: "" }; //cv��ǰ��        v=ֵ  r=�� c=��
                    var _pv = { v: "", r: "", c: "" }; //pv��һ��ֵ     v=ֵ  r=�� c=��
                    _cv.v = _rows[_rlength - 1].cells[i].innerHTML; ;
                    _cv.r = _rlength - 1;
                    _cv.c = i;
                    for (var j = _rlength - 2; j >= 0; j--) {
                        if (_ucols != "") {
                            for (var k = _ucols.length - 1; k >= 0; k--) {
                                if (_ucols[k] == i) {
                                    _pv.v = _rows[j].cells[i].innerHTML;
                                    _pv.r = j;
                                    _pv.c = i;
                                    if (_cv.v == _pv.v) {
                                        rowspan += 1;
                                        _rows[_pv.r].cells[i].rowSpan = rowspan;
                                        _rows[_cv.r].deleteCell(_cv.c);
                                    }
                                    else {
                                        rowspan = 1;
                                    }
                                    _cv.v = _pv.v;
                                    _cv.r = _pv.r;
                                    _cv.c = _pv.c;
                                }
                            }
                        }
                        else {
                            _pv.v = _rows[j].cells[i].innerHTML;
                            _pv.r = j;
                            _pv.c = i;
                            if (_cv.v == _pv.v) {
                                rowspan += 1;
                                _rows[_pv.r].cells[i].rowSpan = rowspan;
                                _rows[_cv.r].deleteCell(_cv.c);
                            }
                            else {
                                rowspan = 1;
                            }
                            _cv.v = _pv.v;
                            _cv.r = _pv.r;
                            _cv.c = _pv.c;
                        }
                    }
                }
            }
            //����ϲ�����        
        }
        conlition();
    }
});