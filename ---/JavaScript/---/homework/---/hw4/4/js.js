document.addEventListener('DOMContentLoaded', () =>
{
    // focus/blur for last and first name
    ['lastName', 'firstName'].forEach(fieldId =>
    {
        const input = document.getElementById(fieldId);
        const msg = document.getElementById(fieldId + 'Msg');
        input.addEventListener('focus', () =>
        {
            msg.textContent = `Please fill in your ${fieldId === 'lastName' ? 'last name' : 'first name'}.`;
        });
        input.addEventListener('blur', () =>
        {
            msg.textContent = '';
        });
    });

    // psychometric score validation
    const scoreInput = document.getElementById('psychScore');
    const scoreMsg = document.getElementById('psychScoreMsg');

    scoreInput.addEventListener('focus', () =>
    {
        scoreMsg.textContent = 'Please enter your psychometric score.';
    });

    scoreInput.addEventListener('blur', () =>
    {
        const value = parseFloat(scoreInput.value);
        if (isNaN(value))
        {
            scoreMsg.textContent = 'Score is required.';
        } else if (value > 555)
        {
            scoreMsg.textContent = 'You can be accepted for studies.';
        } else
        {
            scoreMsg.textContent = 'You must try again next year.';
        }
    });
});
