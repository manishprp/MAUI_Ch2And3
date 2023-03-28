using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Ex8
{
    public class PreviousSolutions
    {
        //int index = 0;


        //if (_answers[index])
        //{
        //    question = _questions[1];
        //    index++;
        //    if(index<_answers.Count)
        //    {
        //        if (_answers[index])
        //        {
        //            question = _questions[3];
        //            index++;
        //            if (index < _answers.Count)
        //            {
        //                if (_answers[index])
        //                {
        //                    question = _questions[7];
        //                }
        //                else
        //                {
        //                    question = _questions[8];
        //                }
        //            }

        //        }
        //        else
        //        {
        //            question = _questions[4];
        //            index++;
        //            if (index < _answers.Count)
        //            {
        //                if (_answers[index])
        //                {
        //                    question = _questions[9];
        //                }
        //                else
        //                {
        //                    question = _questions[10];
        //                }
        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    question = _questions[2];
        //    index++;
        //    if(index < _answers.Count)
        //    {
        //        if (_answers[index])
        //        {
        //            question = _questions[5];
        //            index++;
        //            if(index < _answers.Count)
        //            {
        //                if (_answers[index])
        //                {
        //                    question = _questions[11];
        //                }
        //                else
        //                {
        //                    question = _questions[12];
        //                }
        //            }
        //        }
        //        else
        //        {
        //            question = _questions[6];
        //            index++;
        //            if (_answers[index])
        //            {
        //                if (_answers[index])
        //                {
        //                    question = _questions[13];
        //                }
        //                else
        //                {
        //                    question = _questions[14];
        //                }
        //            }
        //        }
        //    }
        //}


        //for (int i = 0; i < _answers.Count; i++)
        //{
        //    if (countYes < _questions.Count && countNo < _questions.Count)
        //    {
        //        if (_answers[i])
        //        {
        //            question = _questions[countYes];
        //            countYes++;
        //        }
        //        else
        //        {
        //            question = _questions[countNo];
        //            countNo++;
        //        }
        //    }
        //    countYes ++;
        //    countNo ++;
        //}

        /*int index = 0;
        switch (_answers[index])
        {
            case true:
                question = _questions[1];
                index++;
                if (index < _answers.Count)
                {
                    switch (_answers[index])
                    {
                        case true:
                            question = _questions[3];
                            index++;
                            if (index < _answers.Count)
                            {
                                question = _answers[index] ? _questions[7] : _questions[8];
                            }
                            break;
                        case false:
                            question = _questions[4];
                            index++;
                            if (index < _answers.Count)
                            {
                                question = _answers[index] ? _questions[9] : _questions[10];
                            }
                            break;
                    }
                }
                break;
            case false:
                question = _questions[2];
                index++;
                if (index < _answers.Count)
                {
                    switch (_answers[index])
                    {
                        case true:
                            question = _questions[5];
                            index++;
                            if (index < _answers.Count)
                            {
                                question = _answers[index] ? _questions[11] : _questions[12];
                            }
                            break;
                        case false:
                            question = _questions[6];
                            index++;
                            if (index < _answers.Count)
                            {
                                question = _answers[index] ? _questions[13] : _questions[14];
                            }
                            break;
                    }
                }
                break;
        }
        */

    }
}
